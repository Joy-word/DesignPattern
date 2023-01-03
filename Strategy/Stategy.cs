using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Strategy {
    /// <summary>
    /// 动机：
    /// 某些对象使用的算法可能多种多样，经常改变，需要解耦
    /// </summary>
    interface ITextFormater {
        string AppendList(string old, List<string> newTexts);
        string FormatText(string text);
    }

    internal abstract class TextFormaterBase : ITextFormater {
        public abstract string AppendList(string old, List<string> newTexts);

        public virtual string FormatText(string text) {
            text = FormatTextStep1(text);
            return FormatTextStep2(text);
        }

        protected abstract string FormatTextStep2(string text);

        protected string FormatTextStep1(string text) {
            return text.Trim();
        }
    }

    internal class MarkdownTextFormater : TextFormaterBase {
        public override string AppendList(string old, List<string> newTexts) {
            foreach (var text in newTexts) {
                    old += $"\n*{text}";
            }
            return old;
        }

        protected override string FormatTextStep2(string text) {
            throw new NotImplementedException();
        }
    }

    internal class HtmlTextFormater : TextFormaterBase {
        public override string AppendList(string old, List<string> newTexts) {
            foreach (var text in newTexts) {
                old += $"\n<li>{text}</li>";
            }
            return old;
        }

        public override string FormatText(string text) {
            text = base.FormatText(text);
            text = text.ToUpper();
            return text;
        }

        protected override string FormatTextStep2(string text) {
            throw new NotImplementedException();
        }
    }

    internal class StategyTextProcesser {
        public StategyTextProcesser(ITextFormater textFormater) {
            TextFormater = textFormater;
        }
        public ITextFormater TextFormater { get; set; }

        public int Duration { get; set; }
        public void BeginConvert() {

        }
        public string AppendList(string old, List<string> newTexts) {
            return TextFormater.AppendList(old, newTexts);
        }

        public string FormatText(string text) {
            return TextFormater.FormatText(text);
        }
    }
}
