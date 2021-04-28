using HashMap;
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

public class StudentDB : DataU {
  
  HashMap<int, Student> dataB;
  public Student Get(int id) {
    // TODO: 
    return dataB.get(id);
  }

 public Student Get(string name) {
    // TODO: 
    foreach(Student student in dataB.values()) {
      if (student.name == name) {
        return student;
      }
    }
    return null; // if not found return null
  }

  public void Put(Student student) {
    // TODO:
    dataB.put(student.id, student);
  }
}