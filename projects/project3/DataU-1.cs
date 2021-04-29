public interface DataU
{
  Student Get(int id);
  Student Get(string name);
  void Put(Student student);
}

public class Student
{
  public int id;
  public string name;
  public double gpa;
}
