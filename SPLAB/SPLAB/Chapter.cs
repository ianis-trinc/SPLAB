using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SPLAB
{
    public class Chapter
    {
        private string name;
        private List<SubChapter> subChapters = new List<SubChapter>();

        Chapter(Chapter other) { this.name = other.name; }
        public Chapter() { }
        public Chapter(string name)
        {
            this.name = name;
        }   
        
        public string GetName() {  return name; }
        public void SetName(string name) { this.name = name; }

        public int CreateSubChapter(string subChapterName)
        {
            this.subChapters.Add(new SubChapter(subChapterName));
            return subChapters.Count;
        }

        public SubChapter GetSubChapter(int index) { return subChapters[index - 1]; }
    }
}
