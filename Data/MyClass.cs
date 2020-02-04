using System;
using System.ComponentModel.DataAnnotations;

namespace SwaggerDemoApp.Data
{
    public class MyClass
    {
        public string MyString { get; set; }

        public int MyInt { get; set; }

        [Required]
        public Guid Guid { get; set; }
    }
}
