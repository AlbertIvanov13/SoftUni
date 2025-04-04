using CyberSecurityDS.Models.Contracts;
using CyberSecurityDS.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityDS.Repositories
{
    public class DefensiveSoftwareRepository : IRepository<IDefensiveSoftware>
    {
        private readonly List<IDefensiveSoftware> models;

        public DefensiveSoftwareRepository()
        {
            models = new List<IDefensiveSoftware>();
        }
        public IReadOnlyCollection<IDefensiveSoftware> Models { get { return models.AsReadOnly(); } }

        public void AddNew(IDefensiveSoftware model)
        {
            models.Add(model);
        }

        public bool Exists(string name)
        {
            if (models.Any(d => d.Name == name))
            {
                return true;
            }

            return false;
        }

        public IDefensiveSoftware GetByName(string name)
        {
            if (models.Any(d => d.Name == name))
            {
                IDefensiveSoftware defensiveSoftware = models.FirstOrDefault(d => d.Name == name);
                return defensiveSoftware;
            }

            return null;
        }
    }
}