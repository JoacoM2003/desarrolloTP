// import {useState, useSyncExternalStore} from 'react';
 
// export function Login()  {
// 	const  [username, setUsername] =  useState('');
//   const [password, setPassword] = useState('')

// 	const  handleUsernameChange = (event) => {
// 		setUsername(event.target.value);
// 	};

//   const handlePasswordChange = (event) => {
//     setPassword(event.target.value)
//   }

// return  (
// <div>
//   <form>
//     <label>Usuario
//     <input  type="text"  value={username} onChange={handleUsernameChange} />
//     </label>
//     <label>Contraseña
//     <input  type="text"  value={username} onChange={handlePasswordChange} />
//     </label>
//   </form>
// </div>
// )};

import React from "react";
import { useForm } from "react-hook-form";
import axios from 'axios';

export const RegisterForm = () => {
  const { register, handleSubmit } = useForm();
  const handleRegistration = (data) => {
    axios.post("rutaBack", data).then((response)=>{
      console.log(response.status, response.data.token);
    })
  };

  return (
    <form onSubmit={handleSubmit(handleRegistration)}>
      <div>
        <label>Username</label>
        <input name="name" {...register('username')} />
      </div>
      <div>
        <label>Email</label>
        <input type="email" name="email" {...register('email')} />
      </div>
      <div>
        <label>Password</label>
        <input type="password" name="password" {...register('password')} />
      </div>
      <button>Submit</button>
    </form>
  );
};
