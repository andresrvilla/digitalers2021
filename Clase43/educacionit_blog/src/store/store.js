import { createStore } from 'redux';
import { Reducer } from './reducer';
import { initialState } from './initialstate';


const store = createStore(Reducer,
    initialState,
    window.__REDUX_DEVTOOLS_EXTENSION__ && window.__REDUX_DEVTOOLS_EXTENSION__())

export default store;