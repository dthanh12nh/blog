using Neo4jClient;
using System;
using System.Collections.Generic;
using System.Linq;

using PostEntity = TH.Blog.Core.Entities.Post;
using AddPostModel = TH.Blog.Core.Models.AddPost;
using EditPostModel = TH.Blog.Core.Models.EditPost;

namespace TH.Blog.Repositories
{
    public class Post
    {
        Uri _uri;
        GraphClient _client;

        public Post()
        {
            _uri = new Uri("http://localhost:7474/db/data");
            _client = new GraphClient(_uri, "neo4j", "123123");
        }

        public IEnumerable<PostEntity> GetAll()
        {
            _client.Connect();

            return _client
                .Cypher
                .Match("(n:Post)")
                .Set("n.Id = Id(n)")
                .Return(n => n.As<PostEntity>())
                .Results;
        }

        public PostEntity GetById(long id)
        {
            _client.Connect();

            return _client
                .Cypher
                .Match("(n:Post)")
                .Where($"Id(n) = {id}")
                .Set("n.Id = Id(n)")
                .Return(n => n.As<PostEntity>())
                .Results
                .First();
        }

        public void Add(AddPostModel post)
        {
            _client.Connect();
            _client
                .Cypher
                .Create($"(n:Post {{ Title:'{post.Title}', Description:'{post.Description}', Content:'{post.Content}', InsertDate:'{DateTime.Now}' }})")
                .ExecuteWithoutResults();
        }

        public void Edit(long id, EditPostModel post)
        {
            _client.Connect();
            _client
                .Cypher
                .Match("(p:Post)")
                .Where($"Id(p) = {id}")
                .Set($"p.Title = '{post.Title}', p.Description = '{post.Description}', p.Content = '{post.Content}'")
                .ExecuteWithoutResults();
        }

        public void Delete(long id)
        {
            _client.Connect();
            _client
                .Cypher
                .Match("(p:Post)")
                .Where($"Id(p) = {id}")
                .Delete("p")
                .ExecuteWithoutResults();
        }
    }
}
