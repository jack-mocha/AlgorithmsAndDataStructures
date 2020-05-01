using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template
{
    //Keep in mind that the execute method can call an abstract method.
    //The protected keyword allows the method to be visible to the subclasses.
    //Here, the abstract method needs to be protected because we do not want the consumer of this class to directly use DoExecute().
    //The constructor I am using here takes a parameter. We can use an interface instead to decouple.
    //Another way to do this is to initialize AuditTrail in a constructor that does not take a parmeter.
    //In such case, the subclass does not call the base constructor.
    public abstract class Task
    {
        private AuditTrail auditTrail;

        public Task(AuditTrail auditTrail)
        {
            this.auditTrail = auditTrail;
        }

        public void Execute()
        {
            auditTrail.Record();
            DoExecute();
        }

        protected abstract void DoExecute();
    }
}
