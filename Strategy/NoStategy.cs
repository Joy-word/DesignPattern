using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy {
    /// <summary>
    /// 耦合性太强，判断太多
    /// </summary>
    enum OutputFormat {
        Markdown,
        Html,
        //XML
    }

    internal class NoStategyTextProcesser {
        public NoStategyTextProcesser(OutputFormat format) {
            Format = format;
        }
        public OutputFormat Format { get; set; }
        public int Duration { get; set; }

        public string AppendList(string old, List<string> newTexts) {
            foreach (var text in newTexts) {
                if (Format == OutputFormat.Markdown) {
                    old += $"\n*{text}";
                }
                else if (Format == OutputFormat.Html) {
                    old += $"\n<li>{text}</li>";
                }
            }
            return old;
        }

        public string FormatText(string text) {
            switch (Format) {
                case OutputFormat.Markdown:
                    return "...1";
                case OutputFormat.Html:
                    return "...2";
                default:
                    return "...defult";
            }
        }

        public void BeginConvert() {
            Duration = 100;
        }

    }
}
