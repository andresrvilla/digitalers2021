import './App.css';
import Blog from './components/blog/blog.component'
import posts from './datos/posts.json'

import store from './store/store'
import { DECREMENTAR, INCREMENTAR } from './store/actions';

function App() {

  return (
    <>
      <Blog 
        posts={posts} 
        store={store} 
        incrementar={() => store.dispatch(INCREMENTAR())} 
        decrementar={() => store.dispatch(DECREMENTAR())} 
      />
    </>
  );
}

export default App;
