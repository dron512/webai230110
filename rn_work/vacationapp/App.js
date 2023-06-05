import { StatusBar } from 'expo-status-bar';
import { StyleSheet, Text, SafeAreaView } from 'react-native';
import VacationWrite from './components/VacationWrite';

export default function App() {
  return (
    <SafeAreaView style={styles.container}>
      <VacationWrite></VacationWrite>
      <StatusBar style="auto" />
    </SafeAreaView>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    justifyContent: 'center',
  },
});
