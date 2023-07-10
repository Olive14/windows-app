using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_app {
	public partial class Form1 : Form {
		//四則演算
		private int SelectedOperatorIndex = 0;
		private string Operand1 = "";
		private string Operand2 = "";

		//べき乗計算
		private string BaseInput = "";
		private string ExponentiationInput = "";

		//エラーメッセージ
		private const string ErrMsgInvalidParam = "数字を入力してください.";
		private const string ErrMsgDividedByZero = "0で除算はできません.";
		private const string ErrMsgUnexpectedOperation = "想定外の演算が実行されました.";
		private const string ErrMsgOverflowOperand = "大きすぎまたは小さすぎる値が入力されました.";

		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			//Window表示時にコンボボックスのデフォルトの値が選択されている状態にする
			OperatorComboBox.SelectedIndex = SelectedOperatorIndex;
		}

		//TitleLabelがクリックされた
		private void TitleLabel_Click(object sender, EventArgs e) {
			// Do nothing...
		}

		/************
		 * 四則演算 *
		 ************/
		//AnswerLabelがクリックされた
		private void AnswerLabel_Click(object sender, EventArgs e) {
			// Do nothing...
		}

		//ExecuteCalcBtnがクリックされた
		private void ExecuteCalcBtn_Click(object sender, EventArgs e) {
			//オペランド未入力チェック
			if (IsInalidOperand()) {
				AnswerLabel.Text = ErrMsgInvalidParam;
				return;
			}

			//ゼロ除算チェック
			if (IsDevidedByZero()) {
				AnswerLabel.Text = ErrMsgDividedByZero;
				return;
			}

			AnswerLabel.Text = ExecCalc();
		}

		private bool IsInalidOperand() {
			return (Operand1.Length == 0 || Operand2.Length == 0);
		}

		private bool IsDevidedByZero() {
			if ((SelectedOperatorIndex != (int)CalcOperatorIndex.Divide) && (SelectedOperatorIndex != (int)CalcOperatorIndex.Mod)) {
				return false;
			}

			if (Operand2 == "0") {
				return true;
			} else {
				return false;
			}
		}

		private string ExecCalc() {
			int OperandNumber1;
			int OperandNumber2;

			try {
				OperandNumber1 = Int32.Parse(Operand1);
				OperandNumber2 = Int32.Parse(Operand2);
			} catch(FormatException e) {
				Console.WriteLine("Invalid operand. Operand1: {0}, Operand2: {1}", Operand1, Operand2);
				return ErrMsgInvalidParam;
			} catch(OverflowException e) {
				Console.WriteLine("Overflow operand. Operand1: {0}, Operand2: {1}", Operand1, Operand2);
				return ErrMsgOverflowOperand;
			}

			int Answer;

			switch (SelectedOperatorIndex) {
				case ((int)CalcOperatorIndex.Plus):
					Answer = OperandNumber1 + OperandNumber2;
					break;
				case ((int)CalcOperatorIndex.Minus):
					Answer = OperandNumber1 - OperandNumber2;
					break;
				case ((int)CalcOperatorIndex.Times):
					Answer = OperandNumber1 * OperandNumber2;
					break;
				case ((int)CalcOperatorIndex.Divide):
					Answer = OperandNumber1 / OperandNumber2;
					break;
				case ((int)CalcOperatorIndex.Mod):
					Answer = OperandNumber1 % OperandNumber2;
					break;
				default:
					//通常、この分岐に入ることは無い.
					return ErrMsgUnexpectedOperation;
			}

			return Answer.ToString();
		}

		//四則演算子の項目が変更された
		private void OperatorComboBox_SelectedIndexChanged(object sender, EventArgs e) {
			SelectedOperatorIndex = OperatorComboBox.SelectedIndex;
		}

		//演算子左側の値を更新した
		private void OperandText1_TextChanged(object sender, EventArgs e) {
			Operand1 = OperandText1.Text;
		}

		//演算子右側の値を更新した
		private void OperandText2_TextChanged(object sender, EventArgs e) {
			Operand2 = OperandText2.Text;
		}


		/**************
		 * べき乗計算 *
		 **************/
		//べき乗計算のベース部分
		private void Base_TextChanged(object sender, EventArgs e) {
			BaseInput = Base.Text;
		}

		private void LabelOf_Click(object sender, EventArgs e) {
			//do nothing.
		}

		//べき乗計算の「何乗」の部分
		private void Exponentiation_TextChanged(object sender, EventArgs e) {
			ExponentiationInput = Exponentiation.Text;
		}

		private void LabelExponentiation_Click(object sender, EventArgs e) {
			//do nothing.
		}

		//べき乗計算を実行する
		private void ExecuteExponentiationBtn_Click(object sender, EventArgs e) {
			//初期値から変更せずにべき乗計算ボタン押下時はBaseInputは空文字列。その場合はBase.Textから初期値を取得する。
			int BaseNum = Int32.Parse(BaseInput=="" ? Base.Text : BaseInput);
			//初期値から変更せずにべき乗計算ボタン押下時はExponentiationInputは空文字列。その場合はExponentiation.Textから初期値を取得する。
			int ExponentiationNum = Int32.Parse(ExponentiationInput=="" ? Exponentiation.Text : ExponentiationInput);

			int ExponentiationAns = 1;
			if (ExponentiationNum >= 1) {
				for (int i = 1; i <= ExponentiationNum; i++) {
					ExponentiationAns *= BaseNum;
				}
			}

			ExponentiationAnswer.Text = ExponentiationAns.ToString();
		}
	}

	enum CalcOperatorIndex {
		Plus,
		Minus,
		Times,
		Divide,
		Mod
	}

}
