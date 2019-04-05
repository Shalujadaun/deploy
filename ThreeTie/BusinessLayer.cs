using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThreeTie
{
    public class BusinessLayer
    {
        
     DataAccess DA = new DataAccess();

     public String AddUserDetails(BusinessObject ob)
     {
         try
         {
             return DA.AddUserInformation(ob);
         }
         catch
         {
             throw;

         }
     }
         public int LoginUserDetails(BusinessObject ob)
     {
         try
         {
             return DA.LoginUserInformation(ob);
         }
         catch
         {
             throw;
         }
     }

    
        
     }
    }
   



    
