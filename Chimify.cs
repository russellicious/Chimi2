

public interface IChimify {
    object One { get; set; }

    object Two { get; set; }

    void Chimi (out object One, out object Two);
}

public class Chimify : IChimify {
    private Chimify (object one, object two) {
        one = null;
        two = null;
    }

    public object One { get; set; }

    public object Two { get; set; }

    public void Chimi (out object One, out object Two) {
        throw new System.NotImplementedException();
    }

    public static IChimify Factory (object one, object two) {
        return new Chimify(one, two);
    }
}