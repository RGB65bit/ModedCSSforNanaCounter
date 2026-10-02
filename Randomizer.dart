import 'dart:math';
import 'dart:io';
void main(){
  final random = Random();
  int Count = 0;
  String? OrderStrTemp = "";
  String OrderStr = "";
  while (true){
    print("自然数を入力しろ");
    OrderStrTemp = stdin.readLineSync();
    if(OrderStrTemp != null){
      if(OrderStrTemp != ""){
        if(int.tryParse(OrderStrTemp) != null){
          if(int.parse(OrderStrTemp) > 0){
            String a = OrderStrTemp;
            OrderStr = a;
            break;
          };
        };
      };
    };
  };
  var Goal = [];
  for(var x = 0; x < OrderStr.toString().length; x++){
    Goal.add(int.parse(OrderStr[x]));
  }
  while (true){
    Count = Count + 1;
    var Checker = 0;
    var RandomList = [];
    for(var x = 0; x < OrderStr.toString().length ; x++){
      RandomList.add(random.nextInt(10));
    };
    print('${Count}：${RandomList}');
    for(var x = 0; x < OrderStr.length ; x++){
      if(RandomList[x] == Goal[x]){
        Checker = Checker + 1;
      };
    };
    if(Checker == OrderStr.length){
      break;
    };
  };
  print('${Goal}がそろうまで、${Count}回かかりました！');
  print('理論値は${pow(10,OrderStr.length)}で、理論値に占める${Count/(pow(10,OrderStr.length))}回で合致しました');
}
