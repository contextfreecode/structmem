using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

struct Seq {
    public int Id;
    public List<int> Vals;
}

class Program {
    [MethodImpl(MethodImplOptions.NoInlining)]
    static Seq UppedId(Seq seq) {
        seq.Id += 1;
        return seq;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static void ReportChanges(Seq a) {
        var b = UppedId(a);
        Console.WriteLine(a.Id);
        Console.WriteLine(b.Id);
    }

	static void Main() {
        var a = new Seq { Id = 5, Vals = new List<int> { 6, 7 } };
        ReportChanges(a);
    }
}
