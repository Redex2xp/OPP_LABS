using laba_1_3;

var t1 = new Tree(1);
var t2 = new Tree(4);
var t3 = new Tree(2);
var t4 = new Tree(3);
t1.Trees.Add(t2);
t1.Trees.Add(t3);
t3.Trees.Add(t4);

t1.Print();