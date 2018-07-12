import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import './App.css';
import CustomRoutes from './routes';
import registerServiceWorker from './registerServiceWorker';
import '../node_modules/bootstrap/dist/css/bootstrap.min.css';
import '../node_modules/font-awesome/css/font-awesome.min.css';

ReactDOM.render(<CustomRoutes />, document.getElementById('root'));
registerServiceWorker();
