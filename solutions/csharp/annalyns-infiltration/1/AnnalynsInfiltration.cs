static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        // throw new NotImplementedException("Please implement the (static) QuestLogic.CanFastAttack() method");
        if(knightIsAwake) return false;
        return true;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
       
        if(knightIsAwake || archerIsAwake || prisonerIsAwake) return true;
        return false;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if(!archerIsAwake && prisonerIsAwake) return true;
        return false;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if(((knightIsAwake || !knightIsAwake) && !archerIsAwake && (prisonerIsAwake || !prisonerIsAwake) && petDogIsPresent) || (!knightIsAwake && !archerIsAwake && prisonerIsAwake && (!petDogIsPresent || petDogIsPresent))) return true;
        return false;
        
    }
}
