public class Student{ 
    private readonly int _numberTwo;
    public int NumberThree{get;set;};
    public int NumberTwo;
    constructor(int numberOne,int numberTwo ){
        int numberInitialize=numberOne
        NumberTwo=numberTwo
    }
}

public interface IStudent{
    public string Name{get;set;};
    public int salary {get;set;};
    public string Address{get;set;};
    public string testingDummyBranch {get;set;}
}