using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp.Models
{
     public class User
     {
          public User()
          {
               firstName = "Isaiah";
               lastName = "Haley";
               phoneNumber = "(303)885-2465";
               email = "isaiah.haley.0@gmail.com";
               bio = "Hi I'm Isaiah. I make this drive pretty regularly for work, and enjoy listening to music while I drive.";
          }
          public string firstName { get; set; }
          public string lastName { get; set; }

          public string Name
          {
               get
               {
                    return this.firstName + " " + this.lastName;
               }
          }

          public string phoneNumber { get; set; }

          public string email { get; set; }
          public string bio { get; set; }
     }
}
