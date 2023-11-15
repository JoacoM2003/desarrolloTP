import 'bootstrap/dist/css/bootstrap.css';
import './App.css';
import { Header } from './components/header';
import { Section } from './components/section';
import { Footer } from './components/footer'
import { Principal } from './components/principal';
import {Routes, Route, BrowserRouter} from 'react-router-dom'
import { RegisterForm } from './components/register';

function App() {
  return (
    <div className='App'>
      <RegisterForm/>
    </div>
  );
}

export default App;
