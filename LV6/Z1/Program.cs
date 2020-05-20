using System;

namespace Z1
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            Note note1 = new Note ("Title1", "Text1");
            Note note2 = new Note("Title2", "Text2");
            Note note3 = new Note("Title3", "Text3");

            notebook.AddNote(note1);
            notebook.AddNote(note2);
            notebook.AddNote(note3);

            IAbstractIterator iterator = notebook.GetIterator();

            Note currentNote = iterator.First();
            while (iterator.IsDone == false)
            {
                currentNote.Show();
                currentNote = iterator.Next();
            }
        }
    }
}
