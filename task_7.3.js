class Service {
  constructor() {
    this.list = []
  }
  add(newElement) {
    this.list.push(newElement)
  }
  getById(id){
    console.log(this.list[id])
  }
  getAll(){
      let test = [this.list]
      test.forEach(element => {
          console.log(element)
      });
      console.log(this.list)
  }
  deleteById(id){
    console.log(this.list[id])
    this.list.splice(id, 1)
  }
  updateById(id, content){
    this.list[id] = this.list[id] + content
  }
  replaceById(id, content){
    this.list[id] = content
  }
}
let storage = new Service();
storage.add('sadasd');
storage.add(2432);
storage.add(2432);
storage.getAll()
storage.getById('1')
storage.getById()
storage.deleteById(1)
storage.getAll()
storage.updateById(0,'hehehhe')
storage.updateById(7,'hehehhe')
storage.replaceById(7,'hehehhe')
storage.getAll()
