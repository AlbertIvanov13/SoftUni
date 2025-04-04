using CyberSecurityDS.Models.Contracts;
using CyberSecurityDS.Repositories;
using CyberSecurityDS.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityDS.Models
{
    public class SystemManager : ISystemManager
    {
        private IRepository<ICyberAttack> cyberAttacks;
        private IRepository<IDefensiveSoftware> defensiveSoftwares;

        public SystemManager()
        {
            CyberAttacks = new CyberAttackRepository();
            DefensiveSoftwares = new DefensiveSoftwareRepository();
        }

        public IRepository<ICyberAttack> CyberAttacks
        {
            get { return cyberAttacks; }
            private set { cyberAttacks = value; }
        }

        public IRepository<IDefensiveSoftware> DefensiveSoftwares
        {
            get { return defensiveSoftwares; }
            private set { defensiveSoftwares = value; }
        }
    }
}