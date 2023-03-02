const MyProfile = ({a,b}) => {
    const {age:newAge,name:newName="홍길동"} = a;
    const p2 = b;

    return ( <div>
        <h1>이름 {newName}</h1>
        <h1>나이 {newAge}</h1>
        <h1>특징 {p2}</h1>
    </div> );
}
 
export default MyProfile;