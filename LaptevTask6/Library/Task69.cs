using System.Collections.Generic;

namespace Library
{
    public class Task69<T> {
        public static IEnumerable<T> ShiftSeq<T>(IEnumerable<T> seq1, IEnumerable<T> seq2) {
            IEnumerator<T> en1 = seq1.GetEnumerator();
            IEnumerator<T> en2 = seq2.GetEnumerator();

            bool en1NotEnd = true;
            bool en2NotEnd = true;
            while (en1NotEnd || en2NotEnd) {
                en1NotEnd = en1.MoveNext();
                en2NotEnd = en2.MoveNext();
                if (en1NotEnd) yield return (en1.Current);
                if (en2NotEnd) yield return (en2.Current);
            }
        }
    }
}