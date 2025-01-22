using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WinAppAutomation.Module.BusinessObjects
{
    [DefaultClassOptions]
    
    public class Person : BaseObject
    { 
        
        public Person(Session session)
            : base(session)
        {
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsAdult() 
        { 
            return Age >= 18;
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
           
        }
        
    }
}