using UnityEngine;
using UnityEngine.UI;

public class PokemonCombat : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sp;
    [SerializeField] private Button catchButton;

    private float successRate;

    private void OnEnable()
    {
        sp = GetComponent<SpriteRenderer>();
        sp.sprite = GameManager.Instance.pokemon.sp.sprite;
        successRate = GameManager.Instance.pokemon.successRate;
        catchButton.onClick.AddListener(CatchPokemon);
    }

    private void CatchPokemon()
    {
        float randomValue = Random.Range(0f, 100f);

        if (randomValue <= successRate)
        {
            Debug.Log("Catch Successfully!");
        }
        else
        {
            Debug.Log("Pokemom Escaped...!");
        }
    }
}