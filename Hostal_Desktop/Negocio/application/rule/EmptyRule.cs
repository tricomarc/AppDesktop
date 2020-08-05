using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.application.rule
{
    public class EmptyRule
    {
        public string EmptyMessage(string value, string name)
        {

            try
            {
                IsEmpty(value, name);

                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public void IsEmpty(string value, string name)
        {

            if (value == null || value.Count() == 0 || value.Trim().Count() == 0)
            {

                throw new Exception(
                    "\nEL CAMPO " + name + " NO DEBE ESTAR VACÍO."
                    );
            }
        }
    }
}
