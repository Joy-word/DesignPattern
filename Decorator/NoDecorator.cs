using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.NoDecorator {
    /// <summary>
    /// 问题:
    /// 1. 类型爆炸
    /// 2. 重复代码
    /// </summary>
    internal abstract class MyStream : IDisposable {
        public abstract string Read(int number);
        public abstract void Write(string data);
        public abstract void Seek(int persition);
        public abstract void Dispose();
    }

    #region 基本实现
    internal class MyFileStream : MyStream {
        public override void Dispose() {
            throw new NotImplementedException();
        }

        public override string Read(int number) {
            throw new NotImplementedException();
        }

        public override void Seek(int persition) {
            throw new NotImplementedException();
        }

        public override void Write(string data) {
            throw new NotImplementedException();
        }
    }


    internal class MyNetworkStream : MyStream {
        public override void Dispose() {
            throw new NotImplementedException();
        }

        public override string Read(int number) {
            throw new NotImplementedException();
        }

        public override void Seek(int persition) {
            throw new NotImplementedException();
        }

        public override void Write(string data) {
            throw new NotImplementedException();
        }
    }

    internal class MyMemoryStream : MyStream {
        public override void Dispose() {
            throw new NotImplementedException();
        }

        public override string Read(int number) {
            throw new NotImplementedException();
        }

        public override void Seek(int persition) {
            throw new NotImplementedException();
        }

        public override void Write(string data) {
            throw new NotImplementedException();
        }
    }

    #endregion

    #region 扩展加密实现

    internal class CryptoFileStream : MyFileStream {
        public override string Read(int number) {
            DoSthExtend();
            var file = base.Read(number);
            return file;
        }

        public override void Seek(int persition) {
            DoSthExtend();
            base.Seek(persition);
        }

        public override void Write(string data) {
            DoSthExtend();
            base.Write(data);
        }

        public void DoSthExtend() {

        }
    }

    internal class CryptoNetworkFileStream : MyNetworkStream {
        public override string Read(int number) {
            DoSthExtend();
            var file = base.Read(number);
            return file;
        }

        public override void Seek(int persition) {
            DoSthExtend();
            base.Seek(persition);
        }

        public override void Write(string data) {
            DoSthExtend();
            base.Write(data);
        }

        public void DoSthExtend() {

        }
    }

    internal class CryptoMemoryStream : MyMemoryStream {
        public override string Read(int number) {
            DoSthExtend();
            var file = base.Read(number);
            return file;
        }

        public override void Seek(int persition) {
            DoSthExtend();
            base.Seek(persition);
        }

        public override void Write(string data) {
            DoSthExtend();
            base.Write(data);
        }

        public void DoSthExtend() {

        }
    }

    #endregion

    #region 扩展缓存实现
    //...
    #endregion

    #region 扩展缓存和加密实现
    //...
    #endregion
}
