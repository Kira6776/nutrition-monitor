using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prpr1.Models
{
    internal class UserProfile
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public string Photo { get; set; }

        public UserProfile() { }

        public UserProfile(string fullName, int age, double weight, double height, string photo = null)
        {
            FullName = fullName;
            Age = age;
            Weight = weight;
            Height = height;
            Photo = photo;
        }
    }
}
