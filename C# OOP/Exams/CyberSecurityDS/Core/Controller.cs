using CyberSecurityDS.Core.Contracts;
using CyberSecurityDS.Models;
using CyberSecurityDS.Models.Contracts;
using CyberSecurityDS.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace CyberSecurityDS.Core
{
    public class Controller : IController
    {
        private ISystemManager systemManager;

        public Controller()
        {
            SystemManager = new SystemManager();
        }
        public ISystemManager SystemManager
        {
            get { return systemManager; }
            private set { systemManager = value; }
        }

        public string AddCyberAttack(string attackType, string attackName, int severityLevel, string extraParam)
        {
            if (attackType == typeof(MalwareAttack).Name)
            {
                if (SystemManager.CyberAttacks.Exists(attackName))
                {
                    return String.Format(OutputMessages.EntryAlreadyExists, attackName);
                }
                else
                {
                    ICyberAttack malwareAttack = new MalwareAttack(attackName, severityLevel, extraParam);
                    SystemManager.CyberAttacks.AddNew(malwareAttack);
                    return String.Format(OutputMessages.EntryAddedSuccessfully, attackType, attackName);
                }
            }
            else if (attackType == typeof(PhishingAttack).Name)
            {
                if (SystemManager.CyberAttacks.Exists(attackName))
                {
                    return String.Format(OutputMessages.EntryAlreadyExists, attackName);
                }
                else
                {
                    ICyberAttack phishingAttack = new PhishingAttack(attackName, severityLevel, extraParam);
                    SystemManager.CyberAttacks.AddNew(phishingAttack);
                    return String.Format(OutputMessages.EntryAddedSuccessfully, phishingAttack.GetType().Name, attackName);
                }
            }

            return String.Format(OutputMessages.TypeInvalid, attackType);
        }

        public string AddDefensiveSoftware(string softwareType, string softwareName, int effectiveness)
        {
            if (softwareType == typeof(Firewall).Name)
            {
                if (SystemManager.DefensiveSoftwares.Exists(softwareName))
                {
                    return String.Format(OutputMessages.EntryAlreadyExists, softwareName);
                }
                else
                {
                    IDefensiveSoftware firewall = new Firewall(softwareName, effectiveness);
                    SystemManager.DefensiveSoftwares.AddNew(firewall);
                    return String.Format(OutputMessages.EntryAddedSuccessfully, softwareType, firewall.Name);
                }
            }
            else if (softwareType == typeof(Antivirus).Name)
            {
                if (SystemManager.DefensiveSoftwares.Exists(softwareName))
                {
                    return String.Format(OutputMessages.EntryAlreadyExists, softwareName);
                }
                else
                {
                    IDefensiveSoftware antivirus = new Antivirus(softwareName, effectiveness);
                    SystemManager.DefensiveSoftwares.AddNew(antivirus);
                    return String.Format(OutputMessages.EntryAddedSuccessfully, antivirus.GetType().Name, antivirus.Name);
                }
            }

            return String.Format(OutputMessages.TypeInvalid, softwareType);
        }

        public string AssignDefense(string cyberAttackName, string defensiveSoftwareName)
        {
            ICyberAttack cyberAttack = SystemManager.CyberAttacks.GetByName(cyberAttackName);
            IDefensiveSoftware defensiveSoftware = SystemManager.DefensiveSoftwares.GetByName(defensiveSoftwareName);

            if (!SystemManager.CyberAttacks.Exists(cyberAttackName))
            {
                return String.Format(OutputMessages.EntryNotFound, cyberAttackName);
            }
            
            if (!SystemManager.DefensiveSoftwares.Exists(defensiveSoftwareName))
            {
                return String.Format(OutputMessages.EntryNotFound, defensiveSoftwareName);
            }


            if (SystemManager.DefensiveSoftwares.Models.Any(a => a.AssignedAttacks.Any(a => a == cyberAttackName)))
            {
                IDefensiveSoftware defence = SystemManager.DefensiveSoftwares.Models.FirstOrDefault(a => a.AssignedAttacks.Any(a => a == cyberAttackName));
                return String.Format(OutputMessages.AttackAlreadyAssigned, cyberAttackName, defence.Name);
            }

            defensiveSoftware.AssignAttack(cyberAttackName);
            return String.Format(OutputMessages.AttackAssignedSuccessfully, cyberAttackName, defensiveSoftwareName);
        }

        public string MitigateAttack(string cyberAttackName)
        {
            if (!SystemManager.CyberAttacks.Exists(cyberAttackName))
            {
                return String.Format(OutputMessages.EntryNotFound, cyberAttackName);
            }

            ICyberAttack cyberAttack = SystemManager.CyberAttacks.GetByName(cyberAttackName);
            IDefensiveSoftware defensiveSoftware = SystemManager.DefensiveSoftwares.Models.FirstOrDefault(d => d.AssignedAttacks.Any(a => a == cyberAttackName));

            if (cyberAttack.Status)
            {
                return String.Format(OutputMessages.AttackAlreadyMitigated, cyberAttackName);
            }

            if (SystemManager.DefensiveSoftwares.Models.Any(d => d.AssignedAttacks.Any(a => a == cyberAttackName)))
            {
                if (defensiveSoftware?.GetType().Name == typeof(Firewall).Name && cyberAttack.GetType().Name == typeof(MalwareAttack).Name)
                {
                    if (defensiveSoftware.Effectiveness >= cyberAttack.SeverityLevel)
                    {
                        cyberAttack.MarkAsMitigated();
                        return String.Format(OutputMessages.AttackMitigatedSuccessfully, cyberAttackName);
                    }

                    return String.Format(OutputMessages.SoftwareNotEffectiveEnough, cyberAttackName, defensiveSoftware.Name);
                }

                if (defensiveSoftware?.GetType().Name == typeof(Antivirus).Name && cyberAttack.GetType().Name == typeof(PhishingAttack).Name)
                {
                    if (defensiveSoftware.Effectiveness >= cyberAttack.SeverityLevel)
                    {
                        cyberAttack.MarkAsMitigated();
                        return String.Format(OutputMessages.AttackMitigatedSuccessfully, cyberAttackName);
                    }

                    return String.Format(OutputMessages.SoftwareNotEffectiveEnough, cyberAttackName, defensiveSoftware.Name);
                }

                return String.Format(OutputMessages.CannotMitigateDueToCompatibility, defensiveSoftware?.GetType().Name, cyberAttack.GetType().Name);
            }

            return String.Format(OutputMessages.AttackNotAssignedYet, cyberAttackName);
        }

        public string GenerateReport()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Security:");
            foreach (IDefensiveSoftware item in SystemManager.DefensiveSoftwares.Models.OrderBy(d => d.Name))
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Threads:");
            sb.AppendLine("-Mitigated:");
            foreach (ICyberAttack item in SystemManager.CyberAttacks.Models.OrderBy(c => c.AttackName).Where(c => c.Status))
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("-Pending:");
            foreach (ICyberAttack item in SystemManager.CyberAttacks.Models.OrderBy(c => c.AttackName).Where(c => !c.Status))
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}