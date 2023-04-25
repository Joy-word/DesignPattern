
namespace Decorator.Decorator {
    public interface IMyStream {
        string Read(int number);
        void Write(string data);
        void Seek(int persition);
    }
    internal abstract class MyStream : IMyStream,IDisposable {
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
    internal class CryptoStream : MyStream {
        MyStream fileStream;
        public override string Read(int number) {
            DoSthExtend();
            var file = fileStream.Read(number);
            return file;
        }

        public override void Seek(int persition) {
            DoSthExtend();
            fileStream.Seek(persition);
        }

        public override void Write(string data) {
            DoSthExtend();
            fileStream.Write(data);
        }

        public void DoSthExtend() {

        }

        public override void Dispose() {
        }
    }

    #endregion

    #region 扩展缓存实现
    internal class BufferStream : MyStream {
        MyStream fileStream;
        public override string Read(int number) {
            DoSthExtend2();
            var file = fileStream.Read(number);
            return file;
        }

        public override void Seek(int persition) {
            DoSthExtend2();
            fileStream.Seek(persition);
        }

        public override void Write(string data) {
            DoSthExtend2();
            fileStream.Write(data);
        }

        public void DoSthExtend2() {

        }

        public override void Dispose() {
        }
    }

    #endregion
}
