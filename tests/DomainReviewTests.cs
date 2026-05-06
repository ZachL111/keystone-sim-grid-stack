using KeystoneSimGridStack;

public static class DomainReviewTests
{
    public static void Run()
    {
        var item = new DomainReview(67, 20, 32, 75);
        if (DomainReviewLens.Score(item) != 133) throw new Exception("domain score mismatch");
        if (DomainReviewLens.Lane(item) != "watch") throw new Exception("domain lane mismatch");
    }
}
