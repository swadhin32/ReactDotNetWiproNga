import logo from "../images/logo192.png"
function MainHeader()
{
  return  (
    <div>
        <img src={logo} alt="" style={{ height: "35px", verticalAlign: "top" }} />
       <h2 className='text-primary'> The React Course </h2>
       <h2 className='heading2'> The React Course2 </h2>
  </div>
  );
}
const subHeaderStyle =
{
color: "blueviolet",
backgroundColor: "lightgray"
}
function SubHeader()
{
return (<p style={subHeaderStyle}> The course is very exciting </p>);
}
const Header=()=>
{
return(
       <div>
    <MainHeader/>
    <SubHeader></SubHeader>
       </div>
     )
}

export { Header };