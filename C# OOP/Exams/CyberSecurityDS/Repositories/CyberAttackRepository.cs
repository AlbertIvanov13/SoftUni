using CyberSecurityDS.Models;
using CyberSecurityDS.Models.Contracts;
using CyberSecurityDS.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityDS.Repositories
{
    public class CyberAttackRepository : IRepository<ICyberAttack>
    {
        private readonly List<ICyberAttack> models;

        public CyberAttackRepository()
        {
            models = new List<ICyberAttack>();
        }
        public IReadOnlyCollection<ICyberAttack> Models { get { return models.AsReadOnly(); } }

        public void AddNew(ICyberAttack model)
        {
            models.Add(model);
        }

        public bool Exists(string name)
        {
            if (models.Any(a => a.AttackName == name))
            {
                return true;
            }

            return false;
        }

        public ICyberAttack GetByName(string name)
        {
            if (models.Any(a => a.AttackName == name))
            {
                ICyberAttack attack = models.FirstOrDefault(a => a.AttackName == name);
                return attack;
            }

            return null;
        }
    }
}