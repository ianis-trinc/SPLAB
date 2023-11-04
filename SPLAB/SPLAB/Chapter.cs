using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SPLAB
{
    internal class Chapter : Section
    {
        private string name;
        private List<SubChapter> subChapters = new List<SubChapter>();

        public Chapter(Chapter other) { this.name = other.name; }
        public Chapter() { }

        public Chapter(string title) : base(title)
        {
        }

        public string Name { get { return this.name; } set { this.name = value; } }

        public int CreateSubChapter(string subChapterName)
        {
            subChapters.Add(new SubChapter(subChapterName));
            return subChapters.Count;
        }

        public SubChapter GetSubChapter(int index) { return subChapters[index - 1]; }
    }
}
