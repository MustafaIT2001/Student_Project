namespace Student_Project;

public class Major
{
    // id private
    private int dId;
    
    public int ID { get; set; }
    
    // major name
    public String sMajorName { get;}

    // dr name

    public String sDrName;


    // Method add

    public void Add()
    {
        
    }
    // Method remove

    public void Remove()
    {
        
    }

    // constructor to take 2 par name, major name
    public Major(String sMajorName, String sDrName)
    {
        this.sDrName = sDrName;
        this.sMajorName = sMajorName;
    }
    

    
    // copy constructor.
    public Major(Major myMajor)
    {
        this.dId = myMajor.dId;
        this.sMajorName = myMajor.sMajorName;
        this.sDrName = myMajor.sDrName;
    }



}