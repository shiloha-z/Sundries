// fn main() {
//     let mut my_name: &str = "Pascal";
//     greet(&mut my_name);
//     println!("My name is now: {}", my_name);
//   }
  
//   fn greet( name: &mut &str) {
//     println!("Hello, {}!", name);
//     *name = "Jane";
//     println!("Hello, {}!", name);
//   }


// fn main() {
//     let mut my_name = String::from("Pascal");
//     let mut my_name2 = String::from("Pas");

//     greet(&mut my_name, &mut my_name2);
//     println!("My name is still: {}", my_name);  // my_name 不会改变
// }

// fn greet<'a>(mut name: &'a mut String, new_name: &'a mut String) {
//     println!("Hello, {}!", name);  // 打印原来的名字

//     // 重新绑定 name 到 new_name
//     name = new_name;

//     println!("Hello, {}!", name);  // 打印新名字
// }

struct User {
    active: bool,
    username: String,
    email: String,
    sign_in_count: u64,
}
fn main() {
    let user1 = User {
        email: String::from("someone@example.com"),
        username: String::from("someusername123"),
        active: true,
        sign_in_count: 1,
    };
}
