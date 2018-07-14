import React from 'react'

const RegisterForm = props =>(
    <section id="viewLogin">
        <h2>Login to your account:</h2>
        <form id="formLogin" onSubmit={props.submitHandler}>
          <label>Username:</label>
          <input type="text" name="username" onChange={props.changeHandler} placeholder="Enter your Email" />
          <label>Password:</label>
          <input type="password" name="password" onChange={props.changeHandler} placeholder="Enter your Password" />
          <input type="submit" className="login" value="Login" />
        </form>
      </section>
)

export default RegisterForm