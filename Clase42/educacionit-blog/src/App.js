import './App.css';
import Blog from './components/blog/blog.component'
import posts from './datos/posts.json'

function App() {
  return (
    <>
      <Blog posts={posts} />
    </>
  );
}

export default App;
