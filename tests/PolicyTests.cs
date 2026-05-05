using KeystoneSimGridStack;

public static class PolicyTests
{
    public static void Run()
    {
        var signalcase_1 = new Signal(66, 90, 17, 7, 12);
        if (Policy.Score(signalcase_1) != 201) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_1) != "accept") throw new Exception("decision mismatch");
        var signalcase_2 = new Signal(76, 75, 9, 17, 4);
        if (Policy.Score(signalcase_2) != 140) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_2) != "review") throw new Exception("decision mismatch");
        var signalcase_3 = new Signal(106, 82, 15, 13, 12);
        if (Policy.Score(signalcase_3) != 247) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_3) != "accept") throw new Exception("decision mismatch");
    }
}
