import React from 'react'

const RegisterForm = props =>(
    <section id="viewRegister">
        <h2>Create your account:</h2>
        <form id="formRegister" onSubmit={props.submitHandler}>
          <label>Username:</label>
          <input type="text" name="username" onChange={props.changeHandler} placeholder="Username" />
          <label>Password:</label>
          <input type="password" name="password" onChange={props.changeHandler} placeholder="Password" />
          <label>Repeat Password:</label>
          <input type="password" name="checkPass" onChange={props.changeHandler} placeholder="Repeat Password" />
          <input type="submit" className="register" value="Register" />
        </form>
      </section>
)

export default RegisterForm