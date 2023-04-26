

namespace Decorator.Final {
    public interface IMyStream {
        string Read(int number);
        void Write(string data);
        void Seek(int persition);
    }

    internal abstract class MyStream : IMyStream, IDisposable {
        public abstract string Read(int number);
        public abstract void Write(string data);
        public abstract void Seek(int persition);
        public abstract void Dispose();
    }

    #region 基本实现
    internal class MyFileStream : MyStream {
        public override void Dispose() {
            
        }

        public override string Read(int number) {
            Console.WriteLine("File begin read!");
            return "Hello";
        }

        public override void Seek(int persition) {
            Console.WriteLine("File Seek!");

        }

        public override void Write(string data) {
            Console.WriteLine($"File Write:{data}!");
        }
    }

    internal class MyNetworkStream : MyStream {
        public override void Dispose() {
        }

        public override string Read(int number) {
            Console.WriteLine("Network begin read!");
            return "Hello";
        }

        public override void Seek(int persition) {
            Console.WriteLine("Network Seek!");
        }

        public override void Write(string data) {
            Console.WriteLine($"Network Write:{data}!");

        }
    }

    internal class MyMemoryStream : MyStream {
        public override void Dispose() {
            throw new NotImplementedException();
        }

        public override string Read(int number) {
            Console.WriteLine("Memory begin read!");
            return "Hello";
        }

        public override void Seek(int persition) {
            Console.WriteLine("Memory Seek!");

        }

        public override void Write(string data) {
            Console.WriteLine($"Memory Write:{data}!");
        }
    }

    #endregion

    #region 中间基类
    internal abstract class DecoratorStream : MyStream   {
        public MyStream fileStream;
        public DecoratorStream(MyStream myStream) {
            fileStream = myStream;
        }
    }
    #endregion


    #region 扩展加密实现
    internal class CryptoStream : DecoratorStream {
        public CryptoStream(MyStream myStream) : base(myStream) {
        }

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
            Console.WriteLine("Do Cryp...");
        }

        public override void Dispose() {
        }
    }

    //internal class CryptoStream<T>: MyStream where T : MyStream ,new(){
    //    T stream;
    //    public CryptoStream() {
    //        stream = new T();
    //    }

    //    public override string Read(int number) {
    //        DoSthExtend();
    //        var file = stream.Read(number);
    //        return file;
    //    }

    //    public override void Seek(int persition) {
    //        DoSthExtend();
    //        stream.Seek(persition);
    //    }

    //    public override void Write(string data) {
    //        DoSthExtend();
    //        stream.Write(data);
    //    }

    //    public void DoSthExtend() {
    //        Console.WriteLine("Do Cryp...");
    //    }

    //    public override void Dispose() {
    //    }
    //}

    #endregion

    #region 扩展缓存实现
    internal class BufferStream : DecoratorStream {
        public BufferStream(MyStream myStream) : base(myStream) {
        }

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
            Console.WriteLine("Do Buffer...");
        }

        public override void Dispose() {
        }
    }

    #endregion

}
