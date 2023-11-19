﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmploNexus.AppData;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EmploNexus
{
    public class UserRepository
    {
        private EMPLONEXUS_ emploNexusEntities;

        public UserRepository()
        {
            emploNexusEntities = new EMPLONEXUS_();
        }

        
        public UserAccount GetUserByUsername(String username)
        {
            // re-initialize emploNexusEntities object because sometimes data in the list not updated
            emploNexusEntities = new EMPLONEXUS_();
            // SELECT TOP 1 * FROM USERACCOUNT WHERE username == username
            return emploNexusEntities.UserAccounts.Where(s => s.username == username).FirstOrDefault();
        }

        public List<vw_all_user_role> AllUserRole()
        {
            emploNexusEntities = new EMPLONEXUS_();

            return emploNexusEntities.vw_all_user_role.ToList();
        }

        public ErrorCode Register(String username, String password)
        {
            try
            {
                using (var emploNexusEntities = new EMPLONEXUS_())
                {
                    var newUser = new UserAccount();
                    newUser.username = username;
                    newUser.password = password;

                    emploNexusEntities.UserAccounts.Add(newUser);
                    emploNexusEntities.SaveChanges();

                    return ErrorCode.Success;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return ErrorCode.Error;
            }
        }

        public ErrorCode NewUser(UserAccount aUserAccount, ref String outMessage)
        {
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                emploNexusEntities.UserAccounts.Add(aUserAccount);
                emploNexusEntities.SaveChanges();

                outMessage = "Inserted";
                retValue = ErrorCode.Success;
            }
            catch (Exception ex)
            {
                outMessage = ex.Message;
                MessageBox.Show(ex.Message);
            }
            return retValue;
        }

        public ErrorCode UpdateUser(int? userId, UserAccount aUserAccount, ref String outMessage)
        {
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                // Find the user with id
                UserAccount user = emploNexusEntities.UserAccounts.Where(m => m.userID == userId).FirstOrDefault();
                // Update the value of the retrieved user
                user.username = aUserAccount.username;
                user.password = aUserAccount.password;

                emploNexusEntities.SaveChanges();// Execute the update

                outMessage = "Updated";
                retValue = ErrorCode.Success;
            }
            catch (Exception ex)
            {
                outMessage = ex.Message;
                retValue = ErrorCode.Success;
                MessageBox.Show(ex.Message);
            }
            return retValue;
        }

        public ErrorCode RemoveUser(int? userId, ref String outMessage)
        {
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                UserAccount user = emploNexusEntities.UserAccounts.Where(m => m.userID == userId).FirstOrDefault();
                // Remove the user
                emploNexusEntities.UserAccounts.Remove(user);
                emploNexusEntities.SaveChanges();       // Execute the update

                outMessage = "Deleted";
                retValue = ErrorCode.Success;
            }
            catch (Exception ex)
            {
                outMessage = ex.Message;
                retValue = ErrorCode.Error;
                MessageBox.Show(ex.Message);
            }
            return retValue;
        }

        
        public List<UserAccount> UserAccounts()
        {
            emploNexusEntities = new EMPLONEXUS_();

            return emploNexusEntities.UserAccounts.ToList();
        }

        //public List <UserAccount> GetEmployeeList() 
        //{
        //    emploNexusEntities = new EmploNexus_Entities_N();
        //    return emploNexusEntities.UserAccounts.ToList();
        //}
    }
}
