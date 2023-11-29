public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private Boolean _isComplete;
    
    public Goal(string name, string desc, int points)
    {
        _name = name;
        _description = desc;
        _points = points;
        _isComplete = false;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public Boolean GetStatus()
    {
        return _isComplete;
    }

    public void SetStatus()
    {
        _isComplete = true;
    }

    public int GetPoints()
    {
        return _points;
    }

    public virtual int MarkComplete()
    {
        SetStatus();
        return GetPoints();
    }

    public abstract void DisplayInformation();

    public abstract string GetStringRepresentation();
}