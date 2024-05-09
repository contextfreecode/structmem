using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Program {
    static void Main() {
        var a = new Seq { Id = 5, Vals = new List<int> { 6, 7 } };
        ReportChanges(a);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static void ReportChanges(Seq a) {
        var b = UppedId(a);
        Console.WriteLine(a.Id);
        Console.WriteLine(b.Id);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static Seq UppedId(Seq sequence) {
        sequence.Id += 1;
        return sequence;
    }
}

struct Seq {
    public int Id;
    public List<int> Vals;
}
