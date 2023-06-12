package Review;

public class user {
	private String name;
	private int age;
	private String gender;
	private String tel;
	private String email;
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public int getAge() {
		return age;
	}
	public void setAge(int age) {
		this.age = age;
	}
	public String getGender() {
		return gender;
	}
	public void setGender(String gender) {
		this.gender = gender;
	}
	public String getTel() {
		return tel;
	}
	public void setTel(String tel) {
		this.tel = tel;
	}
	public String getEmail() {
		return email;
	}
	public void setEmail(String email) {
		this.email = email;
	}

	public user(String name, int age, String gender, String tel, String email) {
		this.name = name;
		this.age = age;
		this.gender = gender;
		this.tel = tel;
		this.email = email;
	}
	
	public boolean Teenager() {
		if(this.age>=20) {
			return false;
		}
		else {
			return true;
		}
	}
}





