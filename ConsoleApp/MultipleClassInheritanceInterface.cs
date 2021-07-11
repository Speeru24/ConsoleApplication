using System;

public interface IA {
    void AMethod ();
}

class A : IA {
    public void AMethod () {
        Console.WriteLine ("AMethod");
    }
}

public interface IB {
    void BMethod ();
}

class B : IB {
    public void BMethod () {
        Console.WriteLine ("BMethod");
    }
}

class AB : IA, IB {
    A a = new A ();
    B b = new B ();

    public void AMethod () {
        a.AMethod ();
    }
    public void BMethod () {
        b.BMethod ();
    }

}

class MultipleClassInheritanceInterface {
    public static void Main () {
        AB ab = new AB ();
        ab.AMethod ();
        ab.BMethod ();
        Console.ReadLine ();
    }
}