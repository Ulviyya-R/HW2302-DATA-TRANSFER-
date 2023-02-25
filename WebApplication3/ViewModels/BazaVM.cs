using WebApplication3.Models;

namespace WebApplication3.ViewModels
{
    public class BazaVM
    {
        public List<Product>Products { get; set; }
        public List<Category> Categories { get; set; }

        public BazaVM()
        {
			Products = new List<Product>()
            {
                new Product()
                {
                  Id =1,
                  Name = "Nike Free Run 5.0",
                  Description ="Men's Road Running Shoes",
                  Price = "70$",
                  Category = "Shoes",
				  Image ="https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/3b27eb2b-da90-4a12-bb43-a093ca26b4a3/free-run-5-mens-road-running-shoes-Xp40hf.png"
				},

            new Product()
            {
                Id = 2,
                Name = "Nike Pegasus Trail 4",
                Description = "Men's Waterproof Trail Running",
				Price = "70$",
			  Category = "Shoes",
				Image ="https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b436be86-56ef-4bc0-beec-65f1de781b41/air-zoom-pegasus-39-little-big-kids-road-running-shoes-x7qQR4.png"
			},
            new Product()
            {
                Id = 3,
                Name = "Nike Victory Elite",
			   Description = "Women's Sunglasses",
				Price = "160$",
				  Category = "Glasses",

				Image ="https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/4f9292fa-cbbc-4a79-9976-fbea538e3aad/victory-elite-womens-sunglasses-cm9F7Z.png"

			},

            new Product()
            {
                Id = 4,
                Name = "Nike Chak",
			   Description = "Mirrored Sunglasses",
				Price = "200$",
                Category = "Glasses",
                Image ="https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/ccd51855-0409-4c95-9246-90293cf77a12/chak-mirrored-sunglasses-lmzdDx.png"

			},

            new Product()
            {
                Id = 5,
                Name = "NikeSportswear Essential",
				Description = "Women's Woven Black Jacket",
				Price = "115$",
				Category = "Wear",
				Image ="https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/54e8ff0e-7d94-4a1d-8340-4e39f094b82b/sportswear-essential-womens-woven-jacket-Pz0wRZ.png"

			},

            new Product()
            {
                Id = 6,
                Name = "Nike Sportswear Essential",
				Description = "Women's Woven White Jacket",
				Price = "80$",     
				Category = "Wear",
				Image ="https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/2a96807d-b037-4e3e-8bb8-f3eed6e67200/sportswear-essential-womens-woven-jacket-Pz0wRZ.png"

			},


            new Product()
            {
                Id = 7,
                Name = "Nike Academy Team",
				Description = "Backpack (30L)",
				Price = "100$",
                Category = "Bag",
				Image ="https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/8f3cbdb9-4fc0-45bc-96b1-3bde46da7e9c/academy-team-backpack-30l-qDB2Kk.png"

			},
			 new Product()
			{
				Id = 8,
				Name = "Nike Hayward",
				Description = "Backpack (26L)",
				Price = "60$",
				Category = "Bag",
				Image ="https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/85b65839-837e-48b0-b94e-a6c4082088ef/hayward-backpack-26l-1wD06c.png"

			},


			};

			Category cat1 = new Category()
			{
				Id = 1,
				Name = "Shoes",
				Image = "https://static.nike.com/a/images/f_auto/dpr_1.0,cs_srgb/w_592,c_limit/efcb41d3-9ccd-48b0-8384-039c91280cce/nike-just-do-it.jpg"
			};
			Category cat2 = new Category()
			{
				Id = 2,
				Name = "Bag",
				Image = "https://static.nike.com/a/images/f_auto/dpr_1.0,cs_srgb/w_592,c_limit/c50d1c01-8d53-4acb-97d2-1ae252915a01/nike-just-do-it.png"
			};
			Category cat3 = new Category()
			{
				Id = 3,
				Name = "Wear",
				Image = "https://static.nike.com/a/images/f_auto/dpr_1.0,cs_srgb/w_592,c_limit/0af799f9-68a2-4e03-b455-e59042f7361c/nike-just-do-it.jpg"
			};
			Category cat4 = new Category()
			{
				Id = 4,
				Name = "Glasses",
				Image = "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/a3ba72dc-2f82-4c79-9bb2-73a162233f44/victory-elite-road-tint-sunglasses-Ssj8ht.png"
			};
			Categories = new List<Category>()
			{
				cat1,
				cat2,
				cat3,
				cat4,
			};
		}

	}
}
