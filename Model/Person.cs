using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Person:Entity
    {   
        [Required(AllowEmptyStrings =false,ErrorMessage ="Campo Obrigatório não preenchido",ErrorMessageResourceName ="Nome",ErrorMessageResourceType =typeof(string))]
        public string Name { get; set; }
        [RegularExpression()]
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
                
    }
}
