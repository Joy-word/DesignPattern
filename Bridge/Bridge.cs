using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge {
    /// <summary>
    /// 动机：
    /// 出现多个变化维度
    /// </summary>
    public abstract class BridgeMessager {
        protected BridgeMessagerImp bridgeMessagerBase;

        public BridgeMessager(BridgeMessagerImp bridgeMessager) {
            bridgeMessagerBase = bridgeMessager;
        }

        public abstract void Login(string username, string password);
        public abstract void SendMessage(string message);
        public abstract void SendPicture(string picturePath);

    }

    public abstract class BridgeMessagerImp {
        public abstract void PlaySound();
        public abstract void DrawShape();
        public abstract void WriteText();
        public abstract void Connect();
    }

    #region 平台维度
    class BridgePCMessagerBase : BridgeMessagerImp {
        public override void Connect() {
            //...
        }

        public override void DrawShape() {
            //...
        }

        public override void PlaySound() {
            //...
        }

        public override void WriteText() {
            //...
        }
    }

    class BridgeMobieMessagerBase : BridgeMessagerImp {
        public override void Connect() {
            //...
        }

        public override void DrawShape() {
            //...
        }

        public override void PlaySound() {
            //...
        }

        public override void WriteText() {
            //...
        }
    }

    #endregion


    #region 功能维度
    class BridgeMessagerLite : BridgeMessager {
        public BridgeMessagerLite(BridgeMessagerImp bridgeMessager) : base(bridgeMessager) {
        }

        public override void Login(string username, string password) {
            bridgeMessagerBase.Connect();
            //...
        }

        public override void SendMessage(string message) {
            bridgeMessagerBase.WriteText();
            //...
        }

        public override void SendPicture(string picturePath) {
            bridgeMessagerBase.DrawShape();
        }

    }

    class BridgeMessagerPerfect : BridgeMessager {
        public BridgeMessagerPerfect(BridgeMessagerImp bridgeMessager) : base(bridgeMessager) {
        }

        public override void Login(string username, string password) {
            bridgeMessagerBase.PlaySound();
            bridgeMessagerBase.Connect();
            //...
        }

        public override void SendMessage(string message) {
            bridgeMessagerBase.PlaySound();
            bridgeMessagerBase.WriteText();
            //...
        }

        public override void SendPicture(string picturePath) {
            bridgeMessagerBase.PlaySound();
            bridgeMessagerBase.DrawShape();
            //...
        }


    }

    #endregion
}
