using System;
using System.ComponentModel;
using System.Diagnostics;

namespace cont
{
    public static class AccessControl
    {
        public static void Solutions()
        {
          int nUser;
          int nPassword;
          int nAttempts = 0;       

             do
               {
                 Console.WriteLine("Enter their User:");
                 nUser = Convert.ToInt32(Console.ReadLine());

                 Console.WriteLine("Enter their password:");
                 nPassword = Convert.ToInt32(Console.ReadLine());

                 if ((nUser != 12) || (nPassword != 1234))
                 {
                     Console.WriteLine("Login failed");
                     nAttempts++;

                    if (nAttempts == 3)
                    {
                        break;
                    }

                }
                } while (((nUser != 12) || (nPassword != 1234)) && (nAttempts != 3));

                
                if ((nUser == 12) || (nPassword == 1234))
                {
                    Console.WriteLine("Login successful");
                }
                
            }
        }
    }
  