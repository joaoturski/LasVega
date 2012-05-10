using Microsoft.Xna.Framework;

namespace LasVega.Entity
{
    /// <summary>
    /// Interface que define objetos que serão renderizados dentro do Game,
    /// obedecendo o fluxo de renderização da classe <see cref="Microsoft.Xna.Framework.Game"/>
    /// </summary>
    public interface IGameObject
    {
        void Initialize();
        void LoadContent();
        void UnloadContent();
        void Update(GameTime gameTime);
        void Draw(GameTime gameTime);
    }
}
