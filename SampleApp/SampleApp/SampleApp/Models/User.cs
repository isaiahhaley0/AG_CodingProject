using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SampleApp.Models
{
     public class User : INotifyPropertyChanged
     {
          string FirstName, LastName, PhoneNumber, Email, Bio, ProfilePicture;
          public User()
          {
               
          }

          public string profilePicture
          {
               get
               {
                    return ProfilePicture;
               }
               set
               {
                    ProfilePicture = value;
                    if(PropertyChanged != null)
                    {
                         PropertyChanged(this, new PropertyChangedEventArgs("profilePicture"));
                    }

               }
          }
          public string firstName
          {
               get
               {
                    return FirstName;
               }
                    set
               {
                    FirstName = value;
                    if(PropertyChanged != null)
                    {
                         PropertyChanged(this, new PropertyChangedEventArgs("firstName"));
                    }
                   
               }
          }
          public string lastName {
               get
               {
                    return LastName;
               }
               set
               {
                    LastName = value;
                    if(PropertyChanged != null)
                    {
                         PropertyChanged(this, new PropertyChangedEventArgs("lastName"));
                    }
                    
               }
          }

          public string Name
          {
               get
               {
                    return this.firstName + " " + this.lastName;
               }
          }

          public string phoneNumber {
               get
               {
                    return PhoneNumber;
               }
               set
               {
                    PhoneNumber = value;
                    if (PropertyChanged != null)
                    {
                         PropertyChanged(this, new PropertyChangedEventArgs("phoneNumber"));
                    }
               }
          }

          public string email {
               get
               {
                    return Email;
               }
               set
               {
                    Email = value;
                    if (PropertyChanged != null)
                    {
                         PropertyChanged(this, new PropertyChangedEventArgs("email"));
                    }
               }
          }
          public string bio {
               get
               {
                    return Bio;
               }
               set
               {
                    Bio = value;
                    if (PropertyChanged != null)
                    {
                         PropertyChanged(this, new PropertyChangedEventArgs("bio"));
                    }
               }
          }

          public event PropertyChangedEventHandler PropertyChanged;
     }
}
