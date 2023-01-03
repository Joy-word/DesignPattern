using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge {

    /// <summary>
    /// 1. 子类过多调用基类的方法
    /// 2. 代码重复
    /// 3. 代码膨胀
    /// </summary>
    abstract class NoBridgeMessager {
        public abstract void Login(string username, string password);
        public abstract void SendMessage(string message);
        public abstract void SendPicture(string picturePath);
        public abstract void PlaySound();
        public abstract void DrawShape();
        public abstract void WriteText();
        public abstract void Connect();
    }

    class NoBridgePCMessagerBase : NoBridgeMessager {
        public override void Connect() {
            //...
        }

        public override void DrawShape() {
            //...
        }

        public override void Login(string username, string password) {
            //...
        }

        public override void PlaySound() {
            //...
        }

        public override void SendMessage(string message) {
            //...
        }

        public override void SendPicture(string picturePath) {
            //...
        }

        public override void WriteText() {
            //...
        }
    }

    class NoBridgeMobileMessagerBase : NoBridgeMessager {
        public override void Connect() {
            throw new NotImplementedException();
        }

        public override void DrawShape() {
            throw new NotImplementedException();
        }

        public override void Login(string username, string password) {
            throw new NotImplementedException();
        }

        public override void PlaySound() {
            throw new NotImplementedException();
        }

        public override void SendMessage(string message) {
            throw new NotImplementedException();
        }

        public override void SendPicture(string picturePath) {
            throw new NotImplementedException();
        }

        public override void WriteText() {
            throw new NotImplementedException();
        }
    }

    class NoBridgePCMessagerLite : NoBridgePCMessagerBase {

        public override void Login(string username, string password) {
            base.Connect();
            //...
        }

        public override void SendMessage(string message) {
            base.WriteText();
            //...
        }

        public override void SendPicture(string picturePath) {
            base.DrawShape();
            //...
        }   

    }

    class NoBridgePCMessagerPerfect : NoBridgePCMessagerBase {

        public override void Login(string username, string password) {
            base.PlaySound();
            base.Connect();
            //...
        }

        public override void SendMessage(string message) {
            base.PlaySound();
            base.WriteText();
            //...
        }


    }


    class NoBridgeMobileMessagerLite : NoBridgeMobileMessagerBase {

        public override void Login(string username, string password) {
            base.Connect();
            //...
        }

        public override void SendMessage(string message) {
            base.WriteText();
            //...
        }

        public override void SendPicture(string picturePath) {
            base.DrawShape();
        }

    }

    class NoBridgeMobileMessagerPerfect : NoBridgeMobileMessagerBase {

        public override void Login(string username, string password) {
            base.PlaySound();
            base.Connect();
            //...
        }

        public override void SendMessage(string message) {
            base.PlaySound();
            base.WriteText();
            //...
        }


    }
}
