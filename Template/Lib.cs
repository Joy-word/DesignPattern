using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template {
    public abstract class LibBase {
        public void ToDoSth() {
            Step1();
            if (Step2()) {
                Step3();
            }
            Step4();
            Step5();
        }

        public void Step1() {
            Console.WriteLine("Do LibBase step1.");
        }


        public abstract bool Step2();

        public void Step3() {
            Console.WriteLine("Do LibBase step3.");
        }

        public virtual void Step4() {
            Console.WriteLine("Do LibBase step4.");
        }


        public void Step5() {
            Console.WriteLine("Do LibBase step5.");
        }
    }

    public class LibEx : LibBase {
        public override bool Step2() {
            Console.WriteLine("Do Lib step2.");
            return true;
        }

        public override void Step4() {
            base.Step4();
            Console.WriteLine("Do Lib step4.");
        }
    }
}
