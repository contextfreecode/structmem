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
    static void Report(Seq seq) {
        Console.WriteLine($"{seq.Id} has {seq.Vals.Count}");
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static void ReportChanges(Seq a) {
        var b = UppedId(a);
        a.Vals.Add(0);
        Report(a);
        Report(b);
    }

	static void Main() {
        var a = new Seq { Id = 5, Vals = new List<int> { 6, 7 } };
        ReportChanges(a);
        // Console.WriteLine(a.Vals[0]);
    }
}
