class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven(){
        int a = 40;
        return a;
    }
    // TODO: define the 'RemainingMinutesInOven()' method

    public int RemainingMinutesInOven(int a){
        int expectedTime = 40;
        return expectedTime - a;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method

    public int PreparationTimeInMinutes(int a){
        return a*2;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int a, int b){
        a = 2*a;
        return a+b;
    }
}
