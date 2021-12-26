using System.Collections.Generic;

namespace LaptevTask15 {
    class SafeStack {
        
        private Stack<int> stack;
        
        private object o;

        public int Pop() {
            lock (o) {
                if (stack.Count != 0) {
                    return stack.Pop();
                }

                return -1;
            }
        }

        public void Push(int v) {
            lock (o) {
                stack.Push(v);
            }
        }

        public override string ToString() {
            return stack.ToString();
        }

        public int Length() {
            return stack.Count;
        }
    }
}